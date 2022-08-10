let nameField = document.getElementById("name");
let ageField = document.getElementById("age");

async function GetPersonOnClick()
{
    alert("hello");
    let response = await fetch("https://localhost:44321/api/test/getperson");

    if (response.ok)
    {
        let json = await response.json();

        nameField.innerHTML = json.Name;
        ageField.innerHTML = json.Age;
    }
    else {
        alert("HTML Error" + response.status);
    }
}