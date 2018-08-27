import { Pipe, PipeTransform } from '@angular/core';

@Pipe({name: 'indexOffset'})
export class IndexOffsetPipe implements PipeTransform {
  transform(value: number): number {
    return value + 1;
  }
}