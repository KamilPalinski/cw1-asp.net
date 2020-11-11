(function () {

    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        // 1. read data from the form
        const requestData = JSON.stringify({
            Name: formElement.querySelector('input[name="Name"]').value,
            Description: formElement.querySelector('input[name="Description"]').value,
            isVisible: formElement.querySelector('input[name="IsVisible"]').checked
        });
        // 2. call the application server using fetch method
        const json = {
            method: "POST",
            headers: { "Content-type": "application/json" },
            body: requestData,
        };
        const response = await fetch('api/exchange', json);
        const responseJson = await response.json();
        console.log(responseJson);
        if (responseJson.id >= 0) {
            // 3. un-hide the alertElement when the request has been successful
            alertElement.style.display = "block";
        }
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();
