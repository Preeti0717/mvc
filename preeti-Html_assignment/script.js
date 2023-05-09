function isValidForm(){
    var gender = document.forms["EnrollmentForm"]["Gender"].value;
    if (isValidGender(gender)){
        if(isValidSkills() && ValidateEmail(document.forms["EnrollmentForm"]["Email"].value)){
            if(confirm('Do you want to submit the form?')){
                addStudent();
                return true;
            }
        }
    }
}

function ValidateEmail(email_id) {
    const regex_pattern = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    
    if (regex_pattern.test(email_id)) {
        return true;
    }
    else {
        alert('The email address is not valid');
        return false;
    }
}



function isValidGender(gender){
    if(gender==""){
        alert("Gender Cannot be empty");
        return false;
    }
    return true;
}


function isValidSkills(){

    var java = document.getElementById("Java");
    var html = document.getElementById("HTML");
    var css = document.getElementById("CSS");

    if(java.checked==false&&html.checked==false&&css.checked==false){
        alert("Atleast one skill is required")
        return false;
    }
    return true;
}


function addStudent(){

    var name = document.getElementById('UserName').value;
    var email = document.getElementById('Email').value;
    var web = document.getElementById('Website').value;
    var image = document.getElementById('ImageLink').value;
    var gender = document.forms["EnrollmentForm"]["Gender"].value;

    // For Skills
    var java = document.getElementById("Java");  
    var html = document.getElementById("HTML");  
    var css = document.getElementById("CSS");
    var skills = " ";
    if(java.checked == true) {
        skills = skills + java.value+" ";
      }
    
    if(html.checked == true) {
        
        skills =  skills + html.value+" ";
      }
    
    if(css.checked == true) {
        
        skills =  skills + css.value+" ";
      }

      // get the html table
  // 0 = the first table
  
  var table = document.getElementById('tablebody');

  var img = document.createElement('img');
  img.src = image;
  
  // add new empty row to the table
  // 0 = in the top 
  // table.rows.length = the end

  var newRow = table.insertRow(table.rows.length);

  // add cells to the row
  var cel1 = newRow.insertCell(0);
  var cel2 = newRow.insertCell(1);
  var fade = "fade-in";

  // add values to the cells
  cel1.innerHTML =  "<div class="+fade+"><p> <b>" + name + "</b></p><p>" + gender + "</p><p>" + email + "</p><p> <a href=" + web + " target= _blank>"  + web + "</a></p><p>"+ skills + " </p>";
  cel2.innerHTML =  "<div class="+fade+"><img src= " + image + " alt=User Image class = responsive>";

  
var sPathToDefaultImg = src="./default_image.png";

var replaceImageWithPlaceholderIfNotAvail = function( domImg ) {

  // sanitize domImg
  if ( !domImg || !domImg.nodeName || domImg.nodeName != 'IMG' ) {
    // get all images from DOM
    aImg = document.getElementsByTagName('IMG');
    i    = aImg.length;
    if ( i ) {
      while ( i-- ) {
        replaceImageWithPlaceholderIfNotAvail( aImg[i] );
      }
    }
    return;
  }

  // New_image
  oImg         = new Image();       // create new Image
  oImg.onerror = function() {       // assign onerror
    domImg.src = sPathToDefaultImg; // handler function
  };
  oImg.src     = domImg.src;        // set src of new Image

};

// function_call
replaceImageWithPlaceholderIfNotAvail()




$('#subBtn').on('click', function() {
  if ($('#UserTable').css('opacity') == 0) $('#UserTable').css('opacity', 1);
  else
   {$('#UserTable').css('opacity', 0);}
  
  $('#UserTable').css('opacity', 1).delay(5000);
  
});

}
