<?php

use Illuminate\Database\Seeder;

class MoviesTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('movies')->insert([

            'name'=> 'The Godfather',
            'genre' => 'Action',
            'description' => "Don Vito Corleone, head of a mafia family, decides to handover his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.",
            'cast' => 'Al Pacino'	,
            'rating' => 10	,
            'release_year' => 1972
        ]);

        DB::table('movies')->insert([

            'name'=> 'Star Wars',
            'genre' => 'Sci-Fi',
            'cast' => 'Mark Hamill'	,
            'description' => "The galaxy is in a period of civil war. Rebel spies have stolen plans to the Galactic Empire's Death Star",
            'rating' => 7.5	,
            'release_year' => 1977


        ]);


        
        DB::table('movies')->insert([

            'name'=> 'Silence of the lambs',
            'genre' => 'Horror',
            'cast' => 'Anthony Dawkins'	,
            'description' => "Serial Killer Hannibal Lecter joins forces with the FBI to try and hunt down a killer on the loose",
            'rating' => 9.5	,
            'release_year' => 1996


        ]);



        
        DB::table('movies')->insert([

            'name'=> 'The Shawshank redemption',
            'genre' => 'Action',
            'cast' => 'Anthony Dawkins'	,
            'description' => "Andy Dufresne (Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison.",
            'rating' => 9.5	,
            'release_year' => 1994


        ]);




        
        DB::table('movies')->insert([

            'name'=> 'The Dark Knight',
            'genre' => 'Actio',
            'cast' => 'Christian Bale'	,
            'description' => "With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City.",
            'rating' => 9.7	,
            'release_year' => 2008


        ]);
    }
}
