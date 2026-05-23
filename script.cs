function addNote() {
  const input = document.getElementById("note");
  const list = document.getElementById("list");

  if (input.value.trim() === "") return;

  const li = document.createElement("li");
  li.textContent = input.value;

  list.appendChild(li);

  input.value = "";
}
