function createArticle() {
	let input = document.getElementById("createTitle");
	let textArea = document.getElementById("createContent");
	let articles = document.getElementById("articles");
	
	if (input === null || textArea === null || articles === null) {
		throw new Error("Something is wrong...");
	}

	let article = document.createElement("article");
	let h3 = document.createElement("h3");
	let p = document.createElement("p");

	articles.appendChild(article);

	article.appendChild(h3);
	article.appendChild(p);

	h3.innerHTML = input.value;
	p.innerHTML = textArea.value;

	input.value = "";
	textArea.value = "";
}

document.addEventListener("DOMContentLoaded", x => {
	document
		.getElementById("createArticleButton")
		.addEventListener("click", createArticle);
});

//without listener
// function createArticle() {
// 	let createTitle = document.getElementById('createTitle');
// 	let createContent = document.getElementById('createContent');

// 	if (createTitle.value !== '' && createContent.value !== '') {
// 		let h3 = document.createElement('h3');
// 		h3.textContent = createTitle.value;

// 		let p = document.createElement('p');
// 		p.textContent = createContent.value;

// 		let articles = document.getElementById('articles');
// 		let article = document.createElement('article');
// 		article.appendChild(h3);
// 		article.appendChild(p);

// 		articles.appendChild(article);

// 		createTitle.value = '';
// 		createContent.value = '';
// 	}
// }