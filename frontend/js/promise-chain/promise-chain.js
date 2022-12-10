// function getData(data) { // function returns a promise object
//     return new Promise(function(resolve,reject){
//         setTimeout(function(){

//             if(typeof data === "string")
//             {
//                 resolve(data);
//             }
//             else
//             {
//                 reject(new Error("Please use a string value"));
//             }
//         },10000);

//     });
// }




// getData("Hello")
// .then(response => console.log("Value" + response))
// .catch(err =>  console.error(err));
 
function addTwo(number) {

    return new Promise((resolve,reject) =>{
        setTimeout(function(){
            if (typeof number === "number") {
                resolve(number+2);
            }
            else {
                reject(new Error("Please enter a valid value"));
            }
        },3000);
    });

}

 addTwo("Hi")
 .then(response => {
    console.log(response);
    return response + 2;
 }).then(response2 => console.log(response2))
 .catch(err => console.error(err)); // promise chain