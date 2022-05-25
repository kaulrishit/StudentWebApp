// document.getElementById('btn2').addEventListener('click',get);

function getitems1(){
    var abc=document.getElementById("getid").value;
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
      };
      
     fetch("http://localhost:62294/Student/"+abc, requestOptions)
        .then(response => response.text())
        .then(result => display(result))
        .catch(error => console.log('error', error));
    }
    function display(res1){
        document.getElementById('res2').innerHTML=res1;
    }
function get(){
var requestOptions = {
    method: 'GET',
    redirect: 'follow'
  };
  
 fetch("http://localhost:62294/Student", requestOptions)
    .then(response => response.text())
    .then(result => display(result))
    .catch(error => console.log('error', error));
}
function display(data){
    document.getElementById('res').innerHTML=data;
}

function sendData(){
    let studentName = document.getElementById("input1");

    let studentGender = document.getElementById("input2");

    let studentAge = document.getElementById("input3");

   

    // Creating a XHR object

    let xhr = new XMLHttpRequest();

    let url = "http://localhost:62294/Student";



    // open a connection

    xhr.open("POST", url, true);



    // Set the request header i.e. which type of content you are sending

    xhr.setRequestHeader("Content-Type", "application/json");



    // Create a state change callback

    xhr.onreadystatechange = function () {

        if (xhr.readyState === 4 && xhr.status === 200) {



            // Print received data from server

            result.innerHTML = this.responseText;



        }

    };



    // Converting JSON data to string

    var data = JSON.stringify({  "studentName": studentName.value , "studentGender":studentGender.value, "studentAge":studentAge.value });



    // Sending data with the request

    xhr.send(data);

}
function showData1() {

   

    var id=document.getElementById("input4").value;

    var url="http://localhost:62294/Student/Student/"+id;

    fetch(url)

    .then((res) => res.text())

    .then(ans => showData2(ans))  

    }
  function showData2(data)

  {

      document.getElementById('res').innerHTML=data;

  }


