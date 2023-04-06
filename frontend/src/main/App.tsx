import React from 'react';
import './App.css';
import Navbar from '../NavBar';
import HomeInfo from '../Home';
import MovieList from '../movie/MovieList';
import { Route, Routes } from 'react-router-dom';
import PodcastInfo from '../Podcasts';
import '../styles.css';

//Josh Blad
//Section 04
//Assignment 14
//This contains the main App function for this react website. It calls the other functions and also configures the routing

function App() {
  return (
    <>
      <Navbar />
      <div className="container">
        <Routes>
          <Route path="/" element={<HomeInfo />} />
          <Route path="/podcasts" element={<PodcastInfo />} />
          <Route path="/movies" element={<MovieList />} />
        </Routes>
      </div>
    </>
  );
}

export default App;
