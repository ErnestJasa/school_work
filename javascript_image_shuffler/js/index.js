

let imageSources = ['img/1.jpg', 'img/2.jpg', 'img/3.jpg', 'img/4.jpg', 'img/5.jpg', 'img/6.jpg'];
let showImages = document.querySelector('.show-image');
let shuffleImages = document.querySelector('.shuffle-image');
document.querySelector('body').appendChild(document.createElement('main'));
let main;
let isEnabled = false;

function createMain(){
    main = document.querySelector('main');
    main.remove();  
    document.querySelector('body').appendChild(document.createElement('main'));
    main = document.querySelector('main')
}

showImages.addEventListener('click',()=>{      
    createMain();    
    for(let i = 0; i < imageSources.length; i++){    
        let imageOne = document.createElement('img');
        imageOne.src = imageSources[i];             
        imageOne.style.height = '100px';
        imageOne.style.width = '200px';
        main.appendChild(imageOne);          
    }           
    isEnabled = true;
})

    shuffleImages.addEventListener('click',()=>{
        if(isEnabled){
            let shuffledImages = imageSources.sort((a, b) => 0.7 - Math.random()); 
            createMain();      
            for(let i = 0; i < imageSources.length; i++){    
                let imageOne = document.createElement('img');
                imageOne.src = shuffledImages[i];
                let main = document.querySelector('main');
                imageOne.style.height = '100px';
                imageOne.style.width = '200px';
                main.appendChild(imageOne);
            }
        }
       
    })




 


