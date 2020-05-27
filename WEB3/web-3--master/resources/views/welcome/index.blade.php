@extends('layouts.app')
@section('title', 'page title')
@section('navigation')
    @parent
@endsection
@section('content')
<h3 class="display-4 text-center mb-5 mt-4">Recent Reviews</h3>


@can('create', App\Post::class)
<div class = "mt-3 mb-5 text-center" >
<div class = "mb-4"><label>You can view other people posts and create new ones via this page</label></div>

<a href= "{{route('posts.create')}}" class = "mb-4"> <button class="btn btn-success">New Post</button></a>
</div>

@if(session()->get('success'))
    <div class="alert alert-success">
      <label>{{ session()->get('success') }}</label>  
    </div>
  @endif

<div> <a href="{{ url('pdf') }}" class="btn btn-primary mb-4">Download As PDF</a></div>

@endcan


@cannot('create', App\Post::class)
<div class = "text-center">
<label class="display=3">In order to post a review, you need to </label> <a href='/login'>Login</a> / <a href='/register'>Register</a> first</label>
</div>  
@endcannot


<div class ="mb-5">
@foreach ($post as $post)
<div>


<div class="list-group">
<div href="#" class="list-group-item list-group-item-action flex-column align-items-start">
    <div class="d-flex w-100 justify-content-between">
      <h4 class="mb-3">{{ $post->title}}</h4>
      <small class="text-muted">Last edited at {{ $post->updated_at}}</small>
    </div>
    <div class = "mb-2">      <small class="text-muted">Posted by: {{ $post->user->name }} </small></div>

    <div>    <a class="text-weight-bold" href="{{url('movies') .'/' .$post->movie->id}}">Movie: {{ $post->movie->name }} </a></div>

    <p class="mb-1 mt-5">{{ $post->text}}</p>

    @if (!empty($post->image_name))
    <div class = 'mt-3'>
    <img src="{{ asset('images/' . $post->image_name) }}"    onmouseover="this.src='{{ asset('images/PixelatedImages/' . $post->image_name) }}'"
         onmouseout="this.src='{{ asset('images/' . $post->image_name) }}'"  style="cursor: pointer;">
         </div>
    @endif


<div class = "justify-content-betwewen">
    <div class="mt-5 d-flex flex-row-reverse">
      @can ('update', $post)
      <div><a href="{{ route('posts.edit',$post->id)}}" class="btn btn-primary ml-2">Edit</a></div>
      @endcan
    <div>
      @can ('delete', $post)
       <form action="{{ route('posts.destroy', $post->id)}}" method="post">
                  @csrf
                  @method('DELETE')
                  <div> <button class="btn btn-danger" type="submit">Delete</button></div>
     </form>
     </div>
      @endcan
      </div>
<div>
  </div>
  </div>
  </div>
  </div>
  </div>
@endforeach


@endsection     

</div>