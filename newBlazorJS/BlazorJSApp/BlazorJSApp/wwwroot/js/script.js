var App = App || {}

App.triggerAlert = (forcast) => {
    alert("Temp now is  " + forcast.temperatureC);
};

App.prompt = () => {
    return prompt("What is your name?");
};
App.setName = (name) => {
    document.getElementById('myname').innerText = name;
}