<?php

namespace App\Http\Controllers\Auth;
use App\Http\Controllers\Controller;
use App\User;
use Illuminate\Foundation\Auth\RegistersUsers;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Request;
use Image;



class RegisterController extends Controller
{



    /*
    |--------------------------------------------------------------------------
    | Register Controller
    |--------------------------------------------------------------------------
    |
    | This controller handles the registration of new users as well as their
    | validation and creation. By default this controller uses a trait to
    | provide this functionality without requiring any additional code.
    |
    */

    use RegistersUsers;

    /**
     * Where to redirect users after registration.
     *
     * @var string
     */
    protected $redirectTo = '/home';

    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->middleware('guest');
    }

    /**
     * Get a validator for an incoming registration request.
     *
     * @param  array  $data
     * @return \Illuminate\Contracts\Validation\Validator
     */
    protected function validator(array $data)
    {
        return Validator::make($data, [
            'name' => ['required', 'string', 'max:255'],
            'email' => ['required', 'string', 'email', 'max:255', 'unique:users'],
            'password' => ['required', 'string', 'min:4', 'confirmed'],
            
        ]);
    }

    /**
     * Create a new user instance after a valid registration.
     *
     * @param  array  $data
     * @return \App\User
     */
    public function create(array $data)
    {
        return User::create([
            'name' => $data['name'],
            'email' => $data['email'],
            'password' => Hash::make($data['password']),
        ]);
    }

    protected function registered(Request $request, $user)
    {
        if($request->hasFile('avatar')){ //if the user uploads any picture named avatar,then we would like to grab that and save it inside this variable
            $avatar = $request->avatar;
            $avatarName = time () . '.' . $avatar->extension();

            $path = public_path('/images');
            $image = Image::make($avatar->path());
            $image->encode('png');
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
            $user->save();     
        }
    }

}
