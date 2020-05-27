<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Post extends Model
{
    public function user()
    {
        return $this->belongsTo('App\User');
    }

    public function movie()
    {
        return $this->belongsTo('App\Movie');
    }

    // public function movie()
    // {
    //     return $this->belongsTo('Movie');
    // }

    protected $fillable = [
        'title', 'text', 'user_id', 'movie_id', 'image_name'
    ];
}
