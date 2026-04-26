// ── HR page – Charts & UI ──

new Chart(document.getElementById('deptChart').getContext('2d'), {
  type: 'pie',
  data: {
    labels: ['Engineering','Sales','Marketing','Finance','HR','Operations'],
    datasets: [{ data: [28,20,18,14,11,9], backgroundColor: ['#2563eb','#1db97a','#f97316','#9333ea','#ec4899','#6b7280'], borderWidth: 2, borderColor: '#fff' }]
  },
  options: { plugins: { legend: { position: 'right', labels: { font: { size: 11 }, padding: 14 } }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } } }
});
new Chart(document.getElementById('attendanceChart').getContext('2d'), {
  type: 'bar',
  data: {
    labels: ['Aug','Sep','Oct','Nov','Dec','Jan'],
    datasets: [
      { label: 'Present', data: [94,96,95,97,96,96], backgroundColor: '#1db97a', borderRadius: 4, borderSkipped: false },
      { label: 'Absent', data: [6,4,5,3,4,4], backgroundColor: '#ef4444', borderRadius: 4, borderSkipped: false }
    ]
  },
  options: {
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: { x: { stacked: true, grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } }, y: { stacked: true, grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } } }
  }
});