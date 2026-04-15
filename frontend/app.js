const API_BASE = "/api";

async function loadItems() {
  const response = await fetch(`${API_BASE}/items`);
  const items = await response.json();

  const list = document.getElementById("itemsList");
  list.innerHTML = "";

  items.forEach(item => {
    const li = document.createElement("li");
    li.textContent = item;
    list.appendChild(li);
  });
}

async function addItem() {
  const input = document.getElementById("itemInput");
  const item = input.value.trim();

  if (!item) return;

  await fetch(`${API_BASE}/add/${encodeURIComponent(item)}`, {
    method: "POST"
  });

  input.value = "";
  loadItems();
}

loadItems();
