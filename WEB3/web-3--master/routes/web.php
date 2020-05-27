<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::resource('welcome', 'WelcomeController');
Route::resource('movies', 'MovieController');
Route::resource('user', 'UserController');
Route::resource('posts', 'PostController');
Route::resource('forbidden', 'ForbiddenController');
Route::get('pdf', 'PostController@pdf');
Route::get('admin/posts', 'PostController@Admin');
Route::get('admin/users', 'UserController@Admin');
Route::get('admin', 'PostController@adminIndex');
Route::get('admin/edit/{id}', 'UserController@adminEdit')->name('user.adminEdit');
Route::get('admin/users/create', 'UserController@create')->name('user.create');

Route::get('posts/deleteImage/{id}', 'PostController@deleteImage')->name('posts.deleteImage');

Route::get('/', function () {
    return redirect('/welcome');
});


Auth::routes(); 
Route::get('/home', 'HomeController@index')->name('home');
Route::get('/movies/{user}', 'MovieController@Show');

