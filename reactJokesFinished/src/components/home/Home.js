import {useState, useEffect} from "react";
import Search from "../search/Search";
import Joke from "../joke/Joke";
import {Row} from "react-bootstrap";
const Home = ()=>{
    const [jokes,setJokes] = useState([]);
    const [searchTerm,setSearchTerm ] = useState('');

    const handleSearch = (term)=>{
        setSearchTerm(term)
    }

    useEffect(()=>{
        try{
            fetch(`https://api.chucknorris.io/jokes/search?query=${searchTerm}`)
                .then(response=>response.json())
                .then(data=>setJokes(data.result))
        }catch(msg){
            console.log(msg)
        }
    },[searchTerm])

    searchTerm && console.log(jokes)
    return(
        <div>
            <Search onSearch ={handleSearch}/>
            {jokes && <div>
                <h2 className='mb-4'>Paieskos rezultatai</h2>
                <Row className='m-2'>
                    {jokes?.map(joke=>
                        <Joke
                            id = {joke.id}
                            value = {joke.value}
                            url = {joke.url}
                        />
                    )}
                </Row>
            </div>
            }


        </div>
    )
}

export default Home