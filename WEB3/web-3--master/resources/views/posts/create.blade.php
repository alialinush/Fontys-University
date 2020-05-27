@extends('layouts.app')
@section('title', 'page title')
@section('navigation')
    @parent
@endsection

@section('content')


@can('create', App\Post::class)
  <div>
 @include("posts.form")
</div>
@endcan


@cannot('create', App\Post::class)
<div>
@include("forbidden.index")
</div>
@endcannot


@endsection
