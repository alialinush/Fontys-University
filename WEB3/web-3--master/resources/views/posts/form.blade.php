<div class="row">
 <div class="col-sm-8 offset-sm-2">
    <h3 class="display-4 text-center mb-5">Add a Review</h3>
    @if ($errors->any())
      <div class="alert alert-danger">
        <ul>
            @foreach ($errors->all() as $error)
              <li>{{ $error }}</li>
            @endforeach
        </ul>
      </div><br />
      @endif

      <form method="post" action="{{route('posts.store')}}" enctype="multipart/form-data">
      @csrf
      
      <div class="form-group">
    <label>Select a movie:</label>
    <select class="form-control" type="text"  name="movie_id">
    @foreach($movie as $movie)
    <option value ="{{$movie->id}}"> {{$movie->name}} </option> 
    @endforeach
    </select>
  </div>

          <div class="form-group">    
              <label for="title">Title:</label>
              <input type="text" class="form-control" name="title"/>
          </div>

          <div class="form-group">
              <label for="text">Text:</label>
              <textarea class="form-control" rows="3" name="text"></textarea>
          </div>
          
          <div class="form-group">
          <label for="image">Add an image:</label>
          <input type="file" name="image" class = "py-2" id ="image">
          </div>

          <button type="submit" class="btn btn-success">Post</button>
      </form>
  </div>


</div> 
