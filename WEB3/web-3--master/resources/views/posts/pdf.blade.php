<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

<div>
<h3 class="display-4 text-center mb-5 mt-4">Kino Reviews</h3>

<div class ="mb-5">
@foreach ($post as $post)
<div class="list-group mb-5">
<div href="#" class="list-group-item list-group-item-action flex-column align-items-start">
      <div><h4 class="mb-3 text-center" >{{ $post->title}}</h4></div>
      <div>  <small class="text-muted">Last edited at {{ $post->updated_at}}</small></div>
    <div class = "mb-2">      <small class="text-muted">Posted by: {{ $post->user->name }} </small></div>

    <div>    <a class="text-weight-bold" href="{{url('movies') .'/' .$post->movie->id}}">Movie: {{ $post->movie->name }} </a></div>

    <p class="mb-1 mt-5">{{ $post->text}}</p>
  </div>
  </div>
  </div>
@endforeach


</div>