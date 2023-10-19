import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HistorialPedidoComponent } from './historial-pedido.component';

describe('HistorialPedidoComponent', () => {
  let component: HistorialPedidoComponent;
  let fixture: ComponentFixture<HistorialPedidoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HistorialPedidoComponent]
    });
    fixture = TestBed.createComponent(HistorialPedidoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
