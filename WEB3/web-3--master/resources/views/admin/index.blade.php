@extends('layouts.app')

@section('content')

@cannot('create', App\User::class)
<div>
@include("forbidden.index")
</div>
@endcannot

@can('create', App\User::class)   

<head ><h3 class="display-3 text-center mb-5 mt-3">Choose a section to moderate</h3></head>
<div class = "text-center"> <div class = "d-inline"> <a  class="btn btn-success" href="{{url('admin/users')}}">Users</a>
<head ><h3 class="display-5 text-center mb-3 mt-3">Or</h3></head>

  <a class="btn btn-success" href="{{url('admin/posts')}}">Posts</a></div>

</div>

 @endcan
@endsection