const API_KEY = "2498cec3bd27aaa131fe3f6ce5cfc104";
const ID_WHEATHER = "weather";
navigator.geolocation.getCurrentPosition(onGeoOK, onGeoError);
function onGeoOK(position) {
  const lat = position.coords.latitude;
  const lon = position.coords.longitude;
  const url = `https://api.openweathermap.org/data/2.5/weather?lat=${lat}&lon=${lon}&appid=${API_KEY}&units=metric`;
  fetch(url)
    .then((response) => response.json())
    .then((data) => {
      const weather = document.querySelector(`#${ID_WHEATHER} span:first-child`);
      const city = document.querySelector(`#${ID_WHEATHER} span:last-child`);
      weather.innerText = `${data.weather[0].main} / ${data.main.temp}`;
      city.innerText = data.name;
    });
}
  function onGeoError() {
  alert("Can't find you. No weather for you.");
}