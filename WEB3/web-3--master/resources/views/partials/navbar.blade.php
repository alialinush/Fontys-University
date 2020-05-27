<nav class="navbar navbar-expand-lg navbar-light bg-light">
    <a class="navbar-brand" href="{{ url('/')}}">Kino</a>
    
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>

    <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item active">
                <a class="nav-link" href="{{ url('/')}}">Home <span class="sr-only">(current)</span></a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="{{ url('/movies/')}}">Movies</a>
            </li>
            @guest
            <li class="nav-item">
                <a class="nav-link" href="{{ route('login') }}">{{ __('Login') }}</a>
            </li>
            @if (Route::has('register'))
            <li class="nav-item">
                <a class="nav-link" href="{{ route('register') }}">{{ __('Register') }}</a>
            </li>
            @endif
            @else
            <li class="nav-item">
                <a class="nav-link" href="{{url('/posts/')}}" role="button">
                    My posts <span class="caret"></span>
                </a>
            <li>
            @endguest

            @can('adminPost', App\Post::class)
                            <li class="nav-item">
                            <a class="nav-link" href="{{url('admin')}}" role="button">
                                   Adminstration Panel  <span class="caret"></span>
                                </a>
                            <li>
                            @endcan

                            <div class="dropdown">


        </ul>
        @auth
        <ul class="navbar-nav navbar-right">
            <li>
                <a class="nav-link" href="{{url('/user/')}}" role="button">
                    <img style="border-radius:50%" src="{{auth()->user()->getAvatar()}}" alt="Profile Image" width="25" height="25">
                    {{ Auth::user()->name }} <span class="caret"></span>
                </a>
            </li>
            <li class="nav-item">
                <a href="{{ route('logout') }}" class="nav-link" onclick="event.preventDefault();
                                                     document.getElementById('logout-form').submit();">
                    {{ __('Logout') }}
                </a>

                <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                    @csrf
                </form>
            </li>
        </ul>
        @endauth
    </div>
</nav>