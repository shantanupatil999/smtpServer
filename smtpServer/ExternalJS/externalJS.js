const { post } = require("jquery");

function validation()
{
    var to = $("#idto").val();
    var subject = $("#idsubject").val();
    var body = $("#idbody").val();
    if (to == "") {
        alert("Please Enter the valid data");
    }
    else if (subject == "") {
        alert("Please Enter the Valid data");
    }
    else if (body == "") {
        alert("Please Enter the Valid Data");
    }
    else {
        alert("Email Sent Successfully!")
    }
}

//function save() {


//    var email_data = $("email_form").serialize()
//    $.ajax({
//        type: "post",
//        url: "/Setup/Save",
//        data: email_data,
//        success: function (result) {
//            alert("Email Sent Successfully!")
//        }
  

//    })
//}