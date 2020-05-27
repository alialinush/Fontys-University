
@extends('layouts.app')
@section('title', 'page title')
@section('navigation')
    @parent
@endsection
@section('content')
@can('update', Auth::user())
<div class="row">
    <div class="col-md-12">
    <h3 class="display-4 mb-5 mt-4 text-center ">{{ Auth::user()->name }} Details</h3>
<div>

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


<form method="post" action="{{ route('user.update', Auth::user()->id) }}" enctype="multipart/form-data">
        @method('PATCH') 
        @csrf


        <div class="form-group">
            <label for="title">Name:</label>
              <input type="text" class="form-control" name="name" value= "{{ $user->name}}">
          </div>

          <div class="form-group">
              <label for="text">Email:</label>
              <input type="text" class="form-control" name="email" value= "{{$user->email}}" >
          </div >

          <div class="form-group">
              <label for="text">Password:</label>
              <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password" name="password"/>
          </div >

          <!-- <div class="form-group d-flex flex-column">
          <label for="image">Change your Profile Picture:</label>
          <input type="file" name="image" class = "py-2">
          <div>{{$errors->first('image')}}</div>
          </div> -->

          <label>Change your Profile Image</label>
            <input type="file" name="avatar">

          <button type="submit" class="btn btn-success">Update</button>
</form>
</div>
    </div>
</div>
@endcan
@cannot('update', Auth::user())
@include('forbidden.index')
@endcannot
@endsection