@extends('layouts.app')

@section('content')

@cannot('create', App\User::class)
<div>
@include("forbidden.index")
</div>
@endcannot

@can('create', App\User::class)

<head ><h3 class="display-4 text-center mb-3 mt-3">Users List</h3></head>

<div class = 'text-center mb-5 mt-5'><a  class="btn btn-success " href="{{url('admin/users/create')}}">Add a new user</a></div>
    <table class="table ">
        <thead>
          <th scope="col">Name</th>
            <th scope="col">Email</th>
            <th scope="col">Created At</th>
            <th scope="col">Updated At</th>

            <th scope="col"></th>
            <th scope="col"></th>
        </thead>
        <tbody>
           @foreach($users as $user)
                <tr>
                      <td>{{ $user->name }}</td>
                    <td>{{ $user->email }}</td>
                    <td>{{$user->created_at}}</td>
                    <td>{{$user->updated_at}}</td>

                    <td><a class="btn btn-primary ml-2" href="{{ route('user.adminEdit', $user->id)}}" >Edit</a></td>
                     <td>  <form action="{{ route('user.destroy', $user->id)}}" method="post">
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