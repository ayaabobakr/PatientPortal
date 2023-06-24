

window.addEventListener('load', function () {
    const label = document.querySelector('#welcome');
    fetch('/api/values/GetName', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = "Welcome " + cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});