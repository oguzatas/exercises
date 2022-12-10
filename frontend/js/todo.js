const form = document.querySelector("#todo-form");
const todoInput = document.querySelector("#todo");
const todoList = document.querySelector(".list-group");
const firstCardBody = document.querySelectorAll(".card-body")[0];
const secondCardBody = document.querySelectorAll(".card-body")[1];
const filter = document.querySelector("#filter");
const clearButton = document.querySelector("#clear-todos");


eventListeners();

function eventListeners() { // All event listeners
form.addEventListener("submit",addTodo);
document.addEventListener("DOMContentLoaded",loadAllTodosToUI);
secondCardBody.addEventListener("click",deleteTodo);
filter.addEventListener("keyup",filterTodos);
clearButton.addEventListener("click",clearAllTodos);
}


function clearAllTodos(e)
{
    // deleting from interface
    if(confirm("YOU are going to delete all toDo's. Are you sure?"))
    {
        // todoList.innerHTML = ""; Slow method to delete. You can use it in smaller projects
        while(todoList.firstElementChild != null)
        {
            todoList.removeChild(todoList.firstElementChild);
        }
    }
    //deleting from local storage


}
function filterTodos(e)
{
    const filterValue = e.target.value.toLowerCase();
    const listItems = document.querySelectorAll(".list-group-item");

    listItems.forEach(function(listItem){
        const text = listItem.textContent.toLowerCase();
        if (text.indexOf(filterValue)=== -1)
        {

            listItem.setAttribute("style","display : none !important");
        }
        else 
        {
            listItem.setAttribute("style","display : block" );
        }

    })
}
function deleteTodo(e)
{
  if (e.target.className === "fa fa-remove"){
    e.target.parentElement.parentElement.remove();
    deleteTodoFromStorage(e.target.parentElement.parentElement.textContent);
    showAlert("success","Todo removed");
  }

}

function deleteTodoFromStorage(deletetodo)
{
    let todos = getTodosFromStorage();

    todos.forEach(function(todo,index){
        if (todo === deletetodo){
            todos.splice(index,1); // splice method to delete item from an array
        }
    });

    localStorage.setItem("todos",JSON.stringify(todos));
}
function loadAllTodosToUI()
{
    let todos = getTodosFromStorage();

    todos.forEach(function(todo) {
        addTodoUI(todo);
        
    });
}
function addTodo(e) {
    const newTodo = todoInput.value.trim();
    
    if(newTodo === "")
    {

        
        showAlert("danger","Please enter a proper value");
    }

    else {
    addTodoUI(newTodo);
    addTodoStorage(newTodo);
    showAlert("success","Todo Succesfully added")
    }


    e.preventDefault();

    
}

/* <li class="list-group-item d-flex justify-content-between">
                            Todo 1
                            <a href = "#" class ="delete-item">
                                <i class = "fa fa-remove"></i>
                            </a>

                        </li> */

function addTodoUI(newTodo) { // Adds string value to UI
    //listItem creation
    const listItem = document.createElement("li");
    //Link creation
    const link = document.createElement("a");
    link.href = "#";
    link.className = "delete-item";
    link.innerHTML = "<i class = 'fa fa-remove'></i>";

    listItem.className = "list-group-item d-flex justify-content-between";

    //Text Node 

    listItem.appendChild(document.createTextNode(newTodo));
    listItem.appendChild(link);
    
    
    // adding listItem to todo List

    todoList.appendChild(listItem);
    todoInput.value = "";

}

/*
        <div class="alert alert-danger" role="alert">
  This is a danger alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
</div> */

function showAlert(type,message) {
    const alert = document.createElement("div");

        alert.className = `alert alert-${type}`;
        alert.textContent = message;

        firstCardBody.appendChild(alert);
    

        setTimeout(function()
        {
        alert.remove();
        
        },3000)
        
}

function getTodosFromStorage()
{
    let todos;

    if (localStorage.getItem("todos") === null){
        todos = [];
    }
    else {
        todos = JSON.parse(localStorage.getItem("todos"));
    }
    return todos;

}


function addTodoStorage(newTodo)
{
    let todos = getTodosFromStorage();

    todos.push(newTodo)

    localStorage.setItem("todos",JSON.stringify(todos));


}
