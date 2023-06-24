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
            label.textContent = "Welcome "+cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});

window.addEventListener('load', function () {
    const label = document.querySelector('#name-id');
    fetch('/api/values/GetName', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});

window.addEventListener('load', function () {
    const label = document.querySelector('#national-id');
    fetch('/api/values/GetNid', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});

window.addEventListener('load', function () {
    const label = document.querySelector('#phone-id');
    fetch('/api/values/GetPhone', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});

window.addEventListener('load', function () {
    const label = document.querySelector('#address-id');
    fetch('/api/values/GetAddress', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});

window.addEventListener('load', function () {
    const label = document.querySelector('#age-id');
    fetch('/api/values/GetDOB', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});


window.addEventListener('load', function () {
    const label = document.querySelector('#gender-id');
    fetch('/api/values/GetGender', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});

window.addEventListener('load', function () {
    const label = document.querySelector('#email-id');
    fetch('/api/values/GetEmail', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });

});

window.addEventListener('load', function () {
    const label = document.querySelector('#symp-id');
    fetch('/api/values/GetSympt', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});

window.addEventListener('load', function () {
    const label = document.querySelector('#allergies-id');
    fetch('/api/values/GetAllerg', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});
