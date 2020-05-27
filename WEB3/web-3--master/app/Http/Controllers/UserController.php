<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\User;
use Auth;
use Image;

class UserController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
         $users = User::all();
         return view('users.index', array('user' => $users));  
      }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('admin.users.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
  
        $request->validate([
            'name'=>'required',
            'email'=>'required',
            'password'=>'required',
            ]);

            $user = new User([
                'name' => $request->get('name'),
                'email' => $request->get('email'),
                'password' => $request->get('password'),
                ]);
                $user->save();
                return redirect('/welcome')->with('success', 'User was successfully created!');

    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $user = Auth::user();
        return view('users.index');
    }



    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {

        $user = Auth::user();
        return view('users.update', compact('user'));

    }


    public function adminEdit($id)
    {

        $user = User::find($id);
        return view('admin.users.update', compact('user'));

    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {

            $request->validate([
                'name'=>'required',
                'email'=>'required',
                'password'=>'required|min:4|'
                  
            ]);
    
            $user = User::find($id);
            $user->name =  $request->get('name');
            $user->email = $request->get('email');
            $user->password = $request->get('password');

            if($request->hasFile('avatar')){ //if the user uploads any picture named avatar,then we would like to grab that and save it inside this variable
                $avatar = $request->avatar;
                $avatarName = time () . '.' . $avatar->extension();
    
                $path = public_path('/images');
                $image = Image::make($avatar->path());
                //$image->encode('png');
                $image->fit(250, 250);

                $watermark = Image::make(public_path('images/logo.png'));

                $resizePercentage = 70;//70% less then an actual image (play with this value)
                $watermarkSize = round($image->width() * ((100 - $resizePercentage) / 100), 2); //watermark will be $resizePercentage less then the actual width of the image

                $watermark->resize($watermarkSize, null, function ($constraint) {
                    $constraint->aspectRatio();
                });

                $image->insert($watermark, 'bottom-right', 10, 10);
                
    
                $image->save($path . '/' . $avatarName);
                
                $user->avatar = $avatarName;     
            }
    
            $user->save();
    
            return redirect('/welcome')->with('success', 'User updated!');

    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $user = User::find($id);
        $user->delete();
        return redirect('/welcome')->with('success', 'User deleted!');

    }

    public function Admin()
    {
        $users = User::all();

        return view('admin.users.index', [
            'users' => $users
        ]);
    }
}
