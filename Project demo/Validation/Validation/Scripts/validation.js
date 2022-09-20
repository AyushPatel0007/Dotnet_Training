 
function Submit() {
    var username = $('#name').val();
    var email = $('#email').val();
    email = email.replace(/\s+/g, '');
    var email_regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2, 4})+$/;
    var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    //files
    var allowedFiles = [".doc", ".docx", ".pdf"];
    var fileUpload = $('#resume').val();
    var lblError = document.getElementById("lblError");
    var regex = new RegExp("([a-zA-Z0-9\s_\\.()\-:])+(" + allowedFiles.join('|') + ")$");

    if (username.length < 5) {
        $('#txtusername').append("<p>invalid</p>");
        return false;
    }
    //} else if (email.length == 0) {
    //    $('#txtemail').append("<p>Enter the password</p>");
    //    return false;
    //} 
    //else if (!regex.test(email)) {
    //    $('#txtemail').append("<p>enter the strong password</p>");
    //    return false;
    //} 


   
    if (!regex.test(fileUpload.toLowerCase())) {
        
        $('#valid_upload').append("<p>enter the file extension </p>");

         return false;
    }
}
 