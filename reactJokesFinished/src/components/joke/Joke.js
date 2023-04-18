import {Card, Button} from "react-bootstrap";
import './joke.scss'
let favorieList = [];
const Joke = (props)=>{
    const handleSave = ()=>{
        let obj = {}
        obj["id"] = props.id;
        obj["value"] = props.value;
        obj["url"] = props.url;
        favorieList.push(obj)
        localStorage.setItem('favoriteJokes', JSON.stringify(favorieList))
    }
    return(
        <Card className="m-4 p-2 col-5">
            <Card.Header className=" p-3">{props.value}</Card.Header>
            <Card.Body>
                <div className="m-1"><a href={props.url} target="_blank">Link to joke</a></div>
                <div><Button onClick={handleSave}>Man patinka</Button></div>
            </Card.Body>
        </Card>
    )
}

export default Joke