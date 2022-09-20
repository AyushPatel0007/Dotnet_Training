function makepayment(val) {
    var mobile = $('#PaymentMobileno').val();
    var address = $('#PaymentAddress').val();
    var name = $('#PaymentName').val();
     var card = $('#Cardno').val();

    if (mobile == "" || address == "" || name == "" ) {
        $('#addresstxt').empty();
        $('#addresstxt').append("Enter Address to Deliver");
        $("#multiCollapseExample1").collapse("hide");
        $("#multiCollapseExample2").collapse("hide");
        return;
    }
    
    if (mobile.length != 10) {
        $('#addresstxt').empty();
        $('#addresstxt').append("Enter  10 digit  Mobile");
        $("#multiCollapseExample1").collapse("hide");
        $("#multiCollapseExample2").collapse("hide");
        return;
    }
    $("#multiCollapseExample3").collapse("hide");
    if (val == 2 && card.length != 16) {
        $('#cardtxt').empty();
        $('#addresstxt').empty();
        $('#cardtxt').append("Enter 16 digit Valid card");
        return;
    }
   
    $.ajax({
        type: 'post',
        url: '/Buyer/MakePayment',
         
        data: { Name: name, Address: address, Mobileno: mobile, Mode: val },

        success: function (data) {
            
            window.location.href = "/Buyer/Index";
        },
        error: function (err) {
            console.log(JSON.stringify(err));
            alert(err);
        }

    })
};