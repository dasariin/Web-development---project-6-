// Swiper Carousel
const swiper = new Swiper('.mySwiper', {
  loop: true,
  pagination: { el: '.swiper-pagination', clickable: true },
  autoplay: { delay: 3500, disableOnInteraction: false },
});

// AOS Initialization
AOS.init({ duration: 700, once: true });

// FAQ Toggle
function toggleFaq(button) {
  const answer = button.nextElementSibling;
  answer.style.display = answer.style.display === 'block' ? 'none' : 'block';
}
