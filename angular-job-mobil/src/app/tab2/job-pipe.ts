import { PipeTransform, Pipe } from '@angular/core';
import { Poste } from './poste';
@Pipe({
    name:'jobFilter'
})
export class JobPipe implements PipeTransform {
    transform(Job: Poste[],search: string): Poste[]{
        if(!Job || !search) {
            return Job;
        }

        return Job.filter(Job=>
            Job.titre.toLowerCase().indexOf(search.toLowerCase()) !== -1);
    }
}