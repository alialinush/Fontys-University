@extends('layouts.app')
@section('title', 'page title')
@section('navigation')
    @parent
@endsection

@section('content')

@can ('create', App\Post::class)
<div>
<h3 class="display-4 mb-3 text-center mt-4">Post History</h3>
<p class="display=3 text-center">You can view, edit and delete your posts via this page</p>
</div>


<div>
<div class = " text-center mb-5">
    <a style="margin: 19px;" href="{{ route('posts.create')}}" class="btn btn-success">New Post</a>
</div>  


@if(session()->get('success'))
    <div class="alert alert-success">
      <label>{{ session()->get('success') }}</label>  
    </div>
  @endif
</div>
</div>


@foreach ($post as $post)
<div>
@can('viewOwnPosts', $post)

<div class="list-group">
<div href="#" class="list-group-item list-group-item-action flex-column align-items-start">
    <div class="d-flex w-100 justify-content-between">
      <h4 class="mb-2">{{ $post->title}}</h4>
      <small class="text-muted">Last edited at {{ $post->updated_at}}</small>
    </div>
    <div class = "mb-2">      <small class="text-muted">Posted by: {{ $post->user->name }} </small></div>

    <div>    <a class="text-weight-bold" href="{{url('movies') .'/' .$post->movie->id}}">Movie: {{ $post->movie->name }} </a></div>
    <p class="mb-5 mt-4">{{ $post->text}}</p>
  
    @if (!empty($post->image_name))
    <img src="{{ asset('images/' . $post->image_name) }}"    onmouseover="this.src='{{ asset('images/PixelatedImages/' . $post->image_name) }}'"
         onmouseout="this.src='{{ asset('images/' . $post->image_name) }}'"  style="cursor: pointer;">
    @endif

<div class = "justify-content-betwewen">
    <div class="mt-5 d-flex flex-row-reverse">
      @can ('update', $post)
     <div> <a href="{{ route('posts.edit',$post->id)}}" class="btn btn-primary ml-2">Edit</a> </div>

      @endcan


    <div>
      @can ('delete', $post)
      <form action="{{ route('posts.destroy', $post->id)}}" method="post">
                  @csrf
                  @method('DELETE')
                  <div><button class="btn btn-danger" type="submit">Delete</button></div>
     </form>
     </div>
      @endcan
      </div>
<div>
</div>
</div>
  </div>
</div>

@endcan
</div>

@endforeach


<div class="col-sm-12">

@endcan
@cannot('create', App\Post::class)
<div>
@include('forbidden.index')
</div>
@endcannot
@endsection