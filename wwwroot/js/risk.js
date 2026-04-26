// ── RISK page – Charts & UI ──

new Chart(document.getElementById('severityChart').getContext('2d'), {
  type: 'pie',
  data: { labels: ['High: 23%','Critical: 15%','Medium: 34%','Low: 28%'], datasets: [{ data: [23,15,34,28], backgroundColor: ['#f97316','#ef4444','#2563eb','#1db97a'], borderWidth: 2, borderColor: '#fff' }] },
  options: { plugins: { legend: { position: 'bottom', labels: { font: { size: 11 }, padding: 12 } }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } } }
});
new Chart(document.getElementById('categoryChart').getContext('2d'), {
  type: 'bar',
  data: { labels: ['Technology','Financial','Operations','Legal','HR'], datasets: [{ data: [8,12,10,7,6], backgroundColor: '#ef4444', borderRadius: 5, borderSkipped: false, hoverBackgroundColor: '#dc2626' }] },
  options: { plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } }, scales: { y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } }, x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } } } }
});
new Chart(document.getElementById('radarChart').getContext('2d'), {
  type: 'radar',
  data: {
    labels: ['Financial','Operational','Strategic','Compliance','Reputational','Technology'],
    datasets: [{ data: [65,55,70,50,45,75], backgroundColor: 'rgba(239,68,68,0.25)', borderColor: '#ef4444', borderWidth: 2, pointBackgroundColor: '#ef4444', pointRadius: 4 }]
  },
  options: {
    maintainAspectRatio: false,
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: { r: { grid: { color: '#e5e7eb' }, angleLines: { color: '#e5e7eb' }, pointLabels: { font: { size: 11 }, color: '#6b7280' }, ticks: { display: false }, min: 0, max: 100 } }
  }
});