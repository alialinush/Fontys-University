@extends('layouts.app')
@section('title', 'page title')
@section('navigation')
@parent
@endsection
@section('content')
@can('update', Auth::user())
<h3 class="display-4 mb-5 text-center mt-4">{{ Auth::user()->name }} Details</h3>

<div class="text-center mb-5">
    <img src="{{auth()->user()->getAvatar()}}" alt="Profile Avatar" width="150" height="150" style="border-radius:50%">
</div>

@if(session()->get('success'))
<div class="alert alert-success">
  <label>{{ session()->get('success') }}</label>
</div>
@endif
</div>
</div>

<div>
</div>



<div class="card text-center">
  <div class="card-body">
    <h5 class="card-title">Details:</h5>
    <p class="card-text">
      <div>
        <div class="mb-2">
          <p class="font-weight-bold d-inline">Name:</p>
          <p class="font-weight-light d-inline">{{ Auth::user()->name }}</p>
        </div>
        <div>
          <p class="font-weight-bold d-inline">Email:</p>
          <p class="font-weight-light d-inline">{{ Auth::user()->email }}</p>
        </div>
      </div>
    </p>

    <a style="margin: 19px;" href="{{  route('user.edit', Auth::user()->id) }}" class="btn btn-primary">Edit</a>
  </div>
</div>
@endcan
@cannot('update', Auth::user())
@include('forbidden.index')
@endcannot
@endsection