@extends('layouts.app')
@section('title', 'page title')
@section('navigation')
    @parent
@endsection

@section('content')
<div class="row">
    <div class="col-sm-8 offset-sm-2">
        <h1 class="display-4 text-center mb-5 mt-3">Update a post</h1>

        @if(session()->get('success'))
    <div class="alert alert-success">
      <label>{{ session()->get('success') }}</label>  
    </div>
  @endif

        @if ($errors->any())    
        <div class="alert alert-danger">
            <ul>
                @foreach ($errors->all() as $error)
                <li>{{ $error }}</li>
                @endforeach
            </ul>
        </div>
        <br /> 
        @endif

        <form method="post" action="{{ route('posts.update', $post->id) }}" enctype="multipart/form-data">
            @method('PATCH') 
            @csrf
            <div class="form-group">
            <label for="title">Title:</label>
              <input type="text" class="form-control" name="title" value={{ $post->title }} >
          </div>

          <div class="form-group">
              <label for="text">Text:</label>
              <textarea class="form-control" rows="3" name="text">{{$post->text}}</textarea>
          </div>

          @if (!empty($post->image_name))
          <div class = "form-group">
          <div>   Current image: {{$post->image_name}} 
        <a href="{{ route('posts.deleteImage', $post->id)}}">Delete</a></div>
          </div>
          @endif

          <div class="form-group">
          <label for="image">New Image:</label>
          <input type="file" name="image" class = "py-2" id ="image">
          </div>

<div class = "mt-4">
          <button type="submit" class="btn btn-success">Update</button>
          <button class="btn btn-danger" onclick="goBack()">Return</button>
</div>
          </form>
  </div>
</div>
@endsection
