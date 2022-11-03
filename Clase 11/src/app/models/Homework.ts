import { Exercise } from './Exercise';

export class Homework {
    id: string;
    description: string;
    dueDate: Date;
    score: number;
    exercises: Array<Exercise>;
    rating: number;
    constructor(id:string, description:string, score:number, dueDate:Date, exercises:
Array<Exercise>, rating:number){
        this.id = id;
        this.description = description;
        this.score = score;
        this.dueDate = dueDate;
        this.exercises = exercises;
        this.rating = rating;
    }
}
