import { useEffect, useState } from 'react';
import { Movie } from '../types/movie';

function MovieList() {
  const [movieData, setMovieData] = useState<Movie[]>([]);

  //only calls the api if changes have been made
  useEffect(() => {
    const fetchMovie = async () => {
      const rsp = await fetch('https://localhost:4000/movie');
      const temp = await rsp.json();
      setMovieData(temp);
    };
    fetchMovie();
  }, []);

  //table to return list of movies in Joel's collection
  //maps out all the movies from the api
  return (
    <>
      <div className="row">
        <h4>The Joel Hilton Movie Collection</h4>
      </div>
      <table className="table table-border">
        <thead>
          <tr>
            <th>Category</th>
            <th>Title</th>
            <th>Year</th>
            <th>Director</th>
            <th>Rating</th>
            <th>Edited</th>
            <th>Lent To</th>
            <th>Notes</th>
          </tr>
        </thead>
        <tbody>
          {movieData.map((m) => (
            <tr key={m.movieId}>
              <td>{m.category}</td>
              <td>{m.title}</td>
              <td>{m.year}</td>
              <td>{m.director}</td>
              <td>{m.rating}</td>
              <td>{m.edited}</td>
              <td>{m.lentTo}</td>
              <td>{m.notes}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default MovieList;
