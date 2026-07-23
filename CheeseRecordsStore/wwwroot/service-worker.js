self.addEventListener('install', event => {
    console.log('Service Worker instalado al 100.');
    self.skipWaiting();
});

self.addEventListener('fetch', event => {
    event.respondWith(
        fetch(event.request).catch(() => {
            return new Response('Estás sin conexión a internet.');
        })
    );
});