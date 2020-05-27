@extends('layouts.app')
@section('title', 'Movies')
@section('content')
@cannot('adminPost', App\Post::class)
<div>
@include("forbidden.index")
</div>
@endcannot


@can('adminPost', App\Post::class)

<head ><h3 class="display-4 text-center mb-3 mt-3">Posts List</h3>
<div class = 'text-center mb-5 mt-5'><a  class="btn btn-success " href="{{url('posts/create')}}">Add a new post</a></div>

</head>
  <body>
  <table class="table ">
  <thead>
    <tr>
      <th scope="col">ID</th>
      <th scope="col">User ID</th>
      <th scope="col">Movie ID</th>
      <th scope="col">Title</th>
      <th scope="col">Text</th>
      <th scope="col">Created At</th>
      <th scope="col">Last Updated At</th>
      <th scope="col"></th>
      <th scope="col"></th>

    </tr>
  </thead>
  <tbody>
  @foreach ($post as $post)
    <tr>
      <td>{{$post->id }} </td>
      <td>{{$post->user_id }}</td>
      <td>{{ $post->movie_id }}</td>
      <td>{{ $post->title }}</td>
      <td>{{$post->text = substr($post->text, 0, 30) . '...' }}</td>
      <td>{{ $post->created_at}}</td>
      <td>{{ $post->updated_at }}</td>

     <td>  <a href="{{ route('posts.edit',$post->id)}}" class="btn btn-primary ml-2">Edit</a><td>
      <td>
      <form action="{{ route('posts.destroy', $post->id)}}" method="post">
                  @csrf
                  @method('DELETE')
                  <div><button class="btn btn-danger" type="submit">Delete</button></div>
     </form>
     </td>


    </tr>
  @endforeach

  </tbody>
</table>
@endcan

@endsection

