package COM.TQC.GDD01;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;


public class MainActivity extends AppCompatActivity {
    private Button mButton01;
    private Button mButton02;
    private ListView listview;
    private final MainActivity context = this;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //context = getApplicationContext();
        listview = findViewById(R.id.listview);
        //    TO DO  (1) 按下「圖片」按鈕，顯示一個「YES/NO對話視窗」，對話窗標題顯示【要顯示圖片嗎？】，對話內容顯示【選擇YES 會顯示圖片】，當按下【YES】顯示「R.drawable.tca」的檔案在ImageView當中。 當按下【NO】顯示，清空下方ImageView圖片。
        ArrayList<Integer> array1= new ArrayList<>();
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        array1.add(R.drawable.csf);
        ArrayList<Integer> array2 = new ArrayList<>();
        array2.add(R.drawable.ic_launcher_background);

        final ArrayAdapter adapter1 = new imgAdapter(context,R.layout.row,array1);
        final ArrayAdapter adapter2 = new imgAdapter(context,R.layout.row,array2);
        mButton01 = (Button) findViewById(R.id.button);
        final AlertDialog.Builder builder = new AlertDialog.Builder(context);
        builder.setTitle("要顯示圖片嗎？")
                .setMessage("要顯示圖片嗎？")
                .setPositiveButton("OK", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        listview.setAdapter(adapter1);
                    }
                })
                .setNegativeButton("cancel", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        listview.setAdapter(adapter2);
                    }
                });
        mButton01.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View view) {
                AlertDialog alertDialog=builder.create();
                alertDialog.show();
            }
        });

        //    TO DO  (2) 當按下「清除」按鈕，清空下方ImageView圖片，並用Toast訊息方式於畫面中顯示【已經清除圖片】文字。
        mButton02 = (Button) findViewById(R.id.button2);
        mButton02.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View view) {
                listview.setAdapter(adapter2);
                Toast.makeText(context, "已經清除圖片", Toast.LENGTH_LONG).show();
            }
        });
        //   TO DO  (3) 當ImageView有圖片時，點選該圖會以Log.d訊息方式設定tag為debug並顯示【你點選了圖片】。


    }
}
