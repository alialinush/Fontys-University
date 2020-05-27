<?php

use Illuminate\Database\Seeder;

class PostsTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
                
        DB::table('posts')->insert([

            'user_id'=> 1,
            'movie_id' => 1,
            'title' => Str::random(10)	,
            'text' => Str::random(30),
        ]);


                        
        DB::table('posts')->insert([

            'user_id'=> 2,
            'movie_id' => 2,
            'title' => Str::random(10)	,
            'text' => Str::random(30),
        ]);


                        
        DB::table('posts')->insert([

            'user_id'=> 3,
            'movie_id' => 3,
            'title' => Str::random(10)	,
            'text' => Str::random(30),
        ]);


                        
        DB::table('posts')->insert([

            'user_id'=> 4,
            'movie_id' => 4,
            'title' => Str::random(10)	,
            'text' => Str::random(30),
        ]);



                        
        DB::table('posts')->insert([

            'user_id'=> 5,
            'movie_id' => 5,
            'title' => Str::random(10)	,
            'text' => Str::random(30),
        ]);
    }
}
