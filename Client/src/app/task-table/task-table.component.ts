import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-task-table',
  templateUrl: './task-table.component.html',
  styleUrls: ['./task-table.component.css']
})

export class TaskTableComponent {
  public tasks?: Task[];

  constructor(http: HttpClient) {
    http.get<Task[]>('/api/Tasks').subscribe(result => {
      this.tasks = result;
    }, error => console.error(error));
  }
}

interface Task {
  name : string;
  description : string;
  comments : string;
  status : string;
}
