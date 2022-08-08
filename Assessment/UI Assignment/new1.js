
			 function validateForm(){
						 let name=document.getElementById("name");
						let email=document.getElementById("email");
						let mobile=document.getElementById("mobile");
						let p=document.getElementById("password").value;
						let cp=document.getElementById("cpassword").value;
						
						if (name.value =="") {							 
							document.getElementById('nameerrr').innerHTML="*****Fill the name field*****";
							return false;
						}else{
						document.getElementById('nameerrr').innerHTML="";

						}
						if (mobile.value =="") {							 
							document.getElementById('mobileerrr').innerHTML="**********Fill the mobile field*****";
							return false;
						}else{
						document.getElementById('mobileerrr').innerHTML="";

						}
						if (isNaN(mobile.value)){							 
							document.getElementById('mobileerrr').innerHTML="*****Enter Digit Only*****";
							return false;
						}else{
						document.getElementById('mobileerrr').innerHTML="";

						}
						
						if (email.value =="") {							 
							document.getElementById('emailerrr').innerHTML="*****Fill the email field*****";
							return false;
						} else{
						document.getElementById('emailerrr').innerHTML="";

						}
						if(email.value.indexOf('@')<=0){							 
							document.getElementById('emailerrr').innerHTML="***** @ Invalid Position*****";
							return false;
						} else{
						document.getElementById(''emailerrr'').innerHTML="";

						}
						if(email.value.charAt(email.value.length-4)!='.'&&(email.value.length-3)!='.'){							 
							document.getElementById('emailerrr').innerHTML="***** . Invalid Positon*****";
							return false;
						} else{
						document.getElementById('emailerrr').innerHTML="";

						}
						
						if (p =="") {							 
							document.getElementById('perrr').innerHTML="*****Fill the password field*****";
							return false;
						} else{
						document.getElementById('perrr').innerHTML="";

						}
						if(p.length<7) {							 
							document.getElementById('perrr').innerHTML="*****Enter Strong Password*****";
							return false;
						} else{
						document.getElementById('perrr').innerHTML="";

						}
						if (cp =="") {							 
							document.getElementById('cperrr').innerHTML="*****Fill the Confirm Password field*****";
							return false;
						}else{
						document.getElementById('cperrr').innerHTML="";

						}
						if(cp.length<7) {							 
							document.getElementById('cperrr').innerHTML="*****Enter Strong Password*****";
							return false;
						} else{
						document.getElementById('cperrr').innerHTML="";

						}
						if(cp!=p) {							 
							document.getElementById('cperrr').innerHTML="*****Password Not Matched*****";
							return false;
						}else{
						document.getElementById('cperrr').innerHTML="";

						}
						
						
						
			}