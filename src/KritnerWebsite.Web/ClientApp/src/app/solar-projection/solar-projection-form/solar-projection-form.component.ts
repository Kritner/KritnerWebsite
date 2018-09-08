import { Component, OnInit } from '@angular/core';

import { SolarProjectionFormModel } from '../solar-projection-form-model';

@Component({
  selector: 'app-solar-projection-form',
  templateUrl: './solar-projection-form.component.html',
  styleUrls: ['./solar-projection-form.component.css']
})
export class SolarProjectionFormComponent implements OnInit {
  isExpanded = true;

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  model = new SolarProjectionFormModel(
    25,
    17000,
    180,
    20,
    2400,
    .03
  );
  submitted = false;

  onSubmit() { this.submitted = true; }

  constructor() { }

  ngOnInit() {
  }

}
