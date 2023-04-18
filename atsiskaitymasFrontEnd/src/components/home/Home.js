import {useEffect, useState} from "react";
import {Carousel} from "react-bootstrap";
import {CarouselItem} from "react-bootstrap";
import './Home.css'
const Home = ()=>{
    const [comments, setComments] = useState([])
    useEffect(()=>{
        try{
            fetch(`https://strangerthings-quotes.vercel.app/api/quotes/50`)
                .then(response=>response.json())
                .then(data=>setComments(data))
        }catch (msg){
            console.log(msg)
        }
    },[])
    console.log(comments)


    return(
        <article className='container'>
            <div className='commentContainer card' >
                <Carousel className='' >
                    {comments?.map(comment=>
                        <CarouselItem className='item'>
                            <div className='comment'>
                                <Carousel.Caption>
                                    <div className='text-dark'>
                                        <h4 className='quote' >{comment.quote}</h4>
                                        <p className='author'>{comment.author}</p>
                                    </div>
                                </Carousel.Caption>
                            </div>
                        </CarouselItem>
                    )}
                </Carousel>
            </div>
        </article>
    )
}

export default Home