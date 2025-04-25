import nunjucks from 'nunjucks';
import { writeFileSync } from 'fs';
import cars from './data/cars.json' assert { type: 'json' };

nunjucks.configure('templates', { autoescape: true });

const rendered = nunjucks.render('cars.html', { cars });
writeFileSync('dist/cars.html', rendered);

console.log("Archivo generado en dist/cars.html");
