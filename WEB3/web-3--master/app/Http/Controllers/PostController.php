<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
Use File;
use App\Post;
use App\User;
use App\Movie;
use PDF;
use Image;

class PostController extends Controller
{




    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */

    public function pdf(){
      
        $posts = Post::all(); 
        $pdf = PDF::loadView('posts.pdf',array('post' => $posts));
        return $pdf->download('card.pdf');
       }


    public function index()
    {
        
        $posts = Post::all();
        return view('posts.index', array('post' => $posts));
        
      }


    public function Admin()
    {
        $posts = Post::all();
        return view('admin.posts.index', array('post' => $posts));
    }  


    // public function MovieReviews( Movie $movie )
    // {
    //     $posts = Post::
    // }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $posts = Post::all();
        $movies = Movie::all();
        // $this->storeImage($posts);
        return view('posts.create', array('post'=> $posts), array('movie' => $movies));

    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        #This variable is used to hold the image name if the post has one
        $imageNameHolder = null;
 
        $request->validate([
            'title'=>'required',
            'text'=>'required',
            'movie_id'=>'required',
            'image'=> 'file|image|max:5000',

            ]);

            #Checks if the request has an image
            if ($request->hasFile('image')) {
            $image = $request->file('image');
            $input['imagename'] = time() . '.' . $image->getClientOriginalExtension();
            $destinationPath = public_path('/images');
            $image->move($destinationPath, $input['imagename']);
            $imageNameHolder = $input['imagename'];

            $img = Image::make(public_path('images/' . $imageNameHolder))->fit(300,300)->insert(public_path('watermark.png'))->save(); 
            $imgPixel = Image::make(public_path('images/' . $imageNameHolder))->fit(300,300)->pixelate()->save(public_path('images/PixelatedImages/') . $imageNameHolder ); 


        }

      
        
            $post = new Post([
                'movie_id' => $request->get('movie_id'),
                'title' => $request->get('title'),
                'text' => $request->get('text'),
                'user_id' => auth()->id(),
                'image_name' => $imageNameHolder,

            ]);
            $post->save();

           
                 

            return redirect('/welcome')->with('success', 'Review was successfully posted!');



    }


    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
      */
     public function show($id)
     {
        $posts = Post::all();
        return view('posts.index', array('post' => $posts));
     }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $post = Post::find($id);
        $movies = Movie::all();
        return view('posts.edit', compact('post'), array('movie' => $movies));   
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
        $post = Post::find($id);

        $imageNameHolder = $post->image_name;

        $request->validate([
            'title'=>'required',
            'text'=>'required',
            'image'=> 'file|image|max:5000',

        ]);

        if ($request->hasFile('image')) {
        #Delete the old image from the drive if it exists
        if (!empty($post->image_name)){
        $image_path = public_path('/images').'/'.$post->image_name;
        $image_path_pixlated = public_path('/images/PixelatedImages').'/'.$post->image_name;

        if (File::exists($image_path)) {
            unlink($image_path);
        }

        if (File::exists($image_path_pixlated)) {
           unlink($image_path_pixlated);
       }}
       # Now upload the new image.

            $image = $request->file('image');
            $input['imagename'] = time() . '.' . $image->getClientOriginalExtension();
            $destinationPath = public_path('/images');
            $image->move($destinationPath, $input['imagename']);
            $imageNameHolder = $input['imagename'];

            $img = Image::make(public_path('images/' . $imageNameHolder))->fit(300,300)->insert(public_path('watermark.png'))->save(); 
            $imgPixel = Image::make(public_path('images/' . $imageNameHolder))->fit(300,300)->pixelate()->save(public_path('images/PixelatedImages/') . $imageNameHolder ); 
        }

        $post->title =  $request->get('title');
        $post->text = $request->get('text');
        $post->image_name = $imageNameHolder;



        $post->save();

        return redirect('/welcome')->with('success', 'Post updated!');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $post = Post::find($id);
        $post->delete();

         $image_path = public_path('/images').'/'.$post->image_name;
         $image_path_pixlated = public_path('/images/PixelatedImages').'/'.$post->image_name;

         if (File::exists($image_path)) {
             unlink($image_path);
         }

         if (File::exists($image_path_pixlated)) {
            unlink($image_path_pixlated);
        }

        return redirect('/welcome')->with('success', 'Post deleted!');
    }


    public function deleteImage($id)
    {
        $post = Post::find($id);
        $image_path = public_path('/images').'/'.$post->image_name;
        $image_path_pixlated = public_path('/images/PixelatedImages').'/'.$post->image_name;

        if (File::exists($image_path)) {
            unlink($image_path);
        }

        if (File::exists($image_path_pixlated)) {
           unlink($image_path_pixlated);
        }

        $post->image_name = "";
        $post->save();
        return redirect()->back()->with('success', 'Image deleted!');


    }

    public function adminIndex(){
        return view('admin.index');
    }
}