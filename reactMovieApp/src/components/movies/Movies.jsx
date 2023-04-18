import Movie from "../movie/Movie";
import Search from "../search/Search";
import {useEffect, useState} from "react";
const Movies = ()=>{

    const [search, setSearch] = useState('');
    const [movies, setMovies] = useState([])
    useEffect(()=>{
        fetch(`https://www.omdbapi.com/?s=${search}&apikey=22174c4a`)
            .then(response=>response.json())
            .then(data=>setMovies(data.Search))
    },[search])

    const handleSearch = (term)=>{
        setSearch(term);
    }


    console.log(movies)


    return (
        <div>
            {/*siuncia per props, i search, funkcija handleSearch. onSearch taip pat yra props'as*/}
            <Search onSearch={handleSearch}/>
            <div className="row">
                {movies?.length !== 0 ? <h3>Filmai: </h3> : <h3>Nerastas filmas</h3>}
            {movies?.map(movie=>
                <Movie
                    title = {movie.Title}
                    img = {movie.Poster}
                />
            )}

            </div>


        </div>
    )
}

export default Movies;