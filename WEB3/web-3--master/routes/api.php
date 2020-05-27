<?php

use Illuminate\Http\Request;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

//Route::middleware('auth:api')->get('/posts', function (Request $request) {

    Route::get('posts', 'APIPostController@index');
    Route::get('posts/{post}', 'APIPostController@show');
    Route::post('posts', 'APIPostController@store');
    Route::put('posts/{post}', 'APIPostController@update');
    Route::delete('posts/{post}', 'APIPostController@delete');

Route::middleware('auth:api')->get('/user', function (Request $request) {
    return $request->user();
});
