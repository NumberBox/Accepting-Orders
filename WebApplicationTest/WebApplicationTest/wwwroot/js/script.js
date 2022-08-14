str = document.getElementById("input5");
str.addEventListener('input',function(event) {  
    if(isNaN(event.target.value)){
        document.getElementById("input5").value = "";
    }
});                    
                      
 


