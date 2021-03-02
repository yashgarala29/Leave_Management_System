function validate() {
    var username = document.getElementById("email").value;
    var password = document.getElementById("pass").value;
    if (username == "admin@admin.com" && password == "admin") {
        alert("Login successfully");
        window.location = "index.html"; // Redirecting to other page.
    } else {
        alert("Enter Valid Credentials ");
		window.location = "signin.html"; // login page it self.
    }
}