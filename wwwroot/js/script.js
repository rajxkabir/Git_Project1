
console.log("Froza Horizon Warzone Loaded");

let cards=document.querySelectorAll(".review-card");
cards.forEach(c=>{
c.addEventListener("mouseover",()=>{
c.style.transform="scale(1.05)";
});
c.addEventListener("mouseout",()=>{
c.style.transform="scale(1)";
});
});
