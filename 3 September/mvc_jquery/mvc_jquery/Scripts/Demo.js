<script>
    $(document).ready(function () {
        //var ex = $('#txtemail').keyup(function () {
        //    $("#txtdis").append("key yup");
        //})
        //var ex = $('#txtemail').keydown(function () {
        //    $("#txtdis").append("key down");
        //})

        $("#txtpswd").keyup(function () {
            var ex = $('#txtpswd').val();
            if (ex.length == 0) {
                $("#txtdis").html("Enter the password");
            } else
                if (ex.length < 3 && ex.length >= 1) {
                    $("#txtdis").html("week");
                } else if (ex.length < 5 && ex.length >= 3) {
                    $("#txtdis").html("good");
                } else if (ex.length < 10 && ex.length > 5) {
                    $("#txtdis").html("strong");
                } else if (ex.length >= 10) {
                    $("#txtdis").html("verystrong");
                }

        });

            });

</script>