// ── FINANCE page – Charts & UI ──

// Cash Flow
const cfCtx = document.getElementById('cashFlowChart').getContext('2d');
const gInflow = cfCtx.createLinearGradient(0,0,0,260); gInflow.addColorStop(0,'rgba(29,185,122,0.5)'); gInflow.addColorStop(1,'rgba(29,185,122,0.05)');
const gExpense = cfCtx.createLinearGradient(0,0,0,260); gExpense.addColorStop(0,'rgba(176,110,100,0.6)'); gExpense.addColorStop(1,'rgba(176,110,100,0.1)');
new Chart(cfCtx, {
  type: 'line',
  data: {
    labels: ['Aug','Sep','Oct','Nov','Dec','Jan'],
    datasets: [
      { label: 'Inflow', data: [280000,295000,310000,320000,340000,360000], fill: true, backgroundColor: gInflow, borderColor: '#1db97a', borderWidth: 2, tension: 0.42, pointRadius: 0 },
      { label: 'Expenses', data: [180000,190000,195000,200000,210000,225000], fill: true, backgroundColor: gExpense, borderColor: '#b07060', borderWidth: 2, tension: 0.42, pointRadius: 0 }
    ]
  },
  options: { plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } }, scales: { y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af', callback: v => (v/1000)+'k' } }, x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } } } }
});
// Expense pie
new Chart(document.getElementById('expenseChart').getContext('2d'), {
  type: 'pie',
  data: {
    labels: ['Payroll','Operations','Marketing','R&D','Others'],
    datasets: [{ data: [45,25,15,10,5], backgroundColor: ['#2563eb','#1db97a','#f97316','#9333ea','#6b7280'], borderWidth: 2, borderColor: '#fff' }]
  },
  options: { plugins: { legend: { position: 'right', labels: { font: { size: 11 }, padding: 12 } }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } } }
});