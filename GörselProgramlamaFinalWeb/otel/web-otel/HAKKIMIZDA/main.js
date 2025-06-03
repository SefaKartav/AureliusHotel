// Menü açma fonksiyonu
const showMenu = (toggleId, navId) => {
    const toggle = document.getElementById(toggleId),
        nav = document.getElementById(navId)

    if (toggle && nav) {
        toggle.addEventListener('click', () => {
            nav.classList.toggle('show')
        })
    }
}

showMenu('nav-toggle', 'nav-menu');

// GSAP animasyonları
gsap.to(".first", 1.5, { delay: .5, top: "-100%", ease: Expo.easeInOut });
gsap.to(".second", 1.5, { delay: .7, top: "-100%", ease: Expo.easeInOut });
gsap.to(".third", 1.5, { delay: .9, top: "-100%", ease: Expo.easeInOut });

gsap.from('.home__img', { opacity: 0, duration: 2, delay: 2, x: 60 });
gsap.from('.home__information', { opacity: 0, duration: 3, delay: 2.3, y: 25 });
gsap.from('.anime-text', { opacity: 0, duration: 3, delay: 2.3, y: 25, ease: 'expo.out', stagger: .3 });
gsap.from('.nav__logo', { opacity: 0, duration: 3, delay: 3.2, y: 25, ease: 'expo.out' });
gsap.from('.nav__item', { opacity: 0, duration: 3, delay: 3.2, y: 25, ease: 'expo.out', stagger: .2 });
gsap.from('.home__social', { opacity: 0, duration: 3, delay: 4, y: 25, ease: 'expo.out', stagger: .2 });


// Ana sayfa tıklama
document.querySelector('.nav__link[href="#home"]').addEventListener('click', function (e) {
    e.preventDefault();
    document.querySelector('.home').style.display = 'block';
    document.querySelector('#about').style.display = 'none';
    document.querySelector('#yet').style.display = 'none';
    document.querySelector('#por').style.display = 'none';
    document.querySelector('#ile').style.display = 'none';

    gsap.from('.home__img', { opacity: 0, duration: 1, delay: 1, x: 60 });
    gsap.from('.home__information', { opacity: 0, duration: 1, delay: 1, y: 25 });
    gsap.from('.anime-text', { opacity: 0, duration: 1, delay: 1, y: 25, ease: 'expo.out', stagger: .3 });
    gsap.from('.home__social', { opacity: 0, duration: 1, delay: 1, y: 25, ease: 'expo.out', stagger: .2 });
});

// Hakkımda tıklama
document.querySelector('.nav__link[href="#about"]').addEventListener('click', function (e) {
    e.preventDefault();
    document.querySelector('.home').style.display = 'none';
    document.querySelector('#about').style.display = 'flex';
    document.querySelector('#yet').style.display = 'none';
    document.querySelector('#por').style.display = 'none';
    document.querySelector('#ile').style.display = 'none';
      // Fade-in animasyonu için GSAP kullanımı
      const aboutContents = document.querySelectorAll('.fade-in');
      aboutContents.forEach((content, index) => {
          content.classList.remove('visible'); // Önce görünmez yap
          gsap.fromTo(content, {
              opacity: 0,
              y: 20
          }, {
              opacity: 1,
              y: 0,
              duration: 0.5,
              delay: index * 0.2,
              onStart: () => content.classList.add('visible') // Görünür hale getir
          });
      });
});

// yemek tarifleri tıklama
document.querySelector('.nav__link[href="#yet"]').addEventListener('click', function (e) {
    e.preventDefault();
    document.querySelector('.home').style.display = 'none';
    document.querySelector('#about').style.display = 'none';
    document.querySelector('#yet').style.display = 'block';
    document.querySelector('#por').style.display = 'none';
    document.querySelector('#ile').style.display = 'none';
    const products = document.querySelectorAll('.product');
    // GSAP animasyonlarını uygula
    products.forEach((product, index) => {
    gsap.to(product, { duration: 0.8, delay: index * 0.2, opacity: 1, y: 0, ease: 'back'
      });
    });
});

// Portföy tıklama
document.querySelector('.nav__link[href="#por"]').addEventListener('click', function (e) {
    e.preventDefault();
    document.querySelector('.home').style.display = 'none';
    document.querySelector('#about').style.display = 'none';
    document.querySelector('#yet').style.display = 'none';
    document.querySelector('#por').style.display = 'block';
    document.querySelector('#ile').style.display = 'none';
    gsap.from('.portfolio', { opacity: 0, duration: 1, delay: 1, y: 60 });
});

// İletişim tıklama
document.querySelector('.nav__link[href="#ile"]').addEventListener('click', function (e) {
    e.preventDefault();
    document.querySelector('.home').style.display = 'none';
    document.querySelector('#about').style.display = 'none';
    document.querySelector('#yet').style.display = 'none';
    document.querySelector('#por').style.display = 'none';
    document.querySelector('#ile').style.display = 'block';
    gsap.from('.ile', { opacity: 0, duration: 1, delay: 1, y: 60 });
});
