import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroSistemaComponent } from './registro-sistema.component';

describe('RegistroSistemaComponent', () => {
  let component: RegistroSistemaComponent;
  let fixture: ComponentFixture<RegistroSistemaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RegistroSistemaComponent]
    });
    fixture = TestBed.createComponent(RegistroSistemaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
